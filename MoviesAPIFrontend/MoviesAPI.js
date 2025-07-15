const API = 'http://localhost:5096/api/Movie';

const form = document.getElementById('movieForm');
const container = document.getElementById('moviesContainer');
const message = document.getElementById('message');

let isEditing = false;

form.addEventListener('submit', async (e) => {
  e.preventDefault();

  const movie = {
    idMovie: parseInt(document.getElementById('idMovie').value),
    title: document.getElementById('title').value,
    releaseYear: document.getElementById('releaseYear').value,
    genre: document.getElementById('genre').value,
    director: document.getElementById('director').value,
    rate: parseInt(document.getElementById('rate').value),
    movieUrl: document.getElementById('movieUrl').value,
    trailerUrl: document.getElementById('trailerUrl').value,
  };

  const method = isEditing ? 'PUT' : 'POST';
  const endpoint = isEditing ? `${API}/UpdateMovies` : `${API}/AddMovies`;

  const res = await fetch(endpoint, {
    method,
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(movie),
  });

  if (res.ok) {
    showMessage(isEditing ? 'Updated!' : 'Movie Added!');
    isEditing = false;
    form.reset();
    loadMovies();
  } else {
    showMessage('Something went wrong!');
  }
});

function showMessage(msg) {
  message.textContent = msg;
  setTimeout(() => (message.textContent = ''), 3000);
}

function renderMovieCard(movie) {
  return `
    <div class="movie-card">
      <img src="${movie.movieUrl}" alt="${movie.title}" onerror="this.src='https://via.placeholder.com/250x200?text=No+Image'">
      <div class="content">
        <h3>${movie.title}</h3>
        <div class="info">🎬 ${movie.genre} | 🎞️ ${movie.director}</div>
        <div class="info">📆 ${movie.releaseYear} | ⭐ ${movie.rate}/10</div>
        ${movie.trailerUrl ? `<a href="${movie.trailerUrl}" target="_blank">▶️ Watch Trailer</a>` : ''}
        <div class="actions">
          <button class="edit" onclick="editMovie(${movie.idMovie})">Edit</button>
          <button onclick="deleteMovie(${movie.idMovie})">Delete</button>
        </div>
      </div>
    </div>
  `;
}

async function loadMovies() {
  const res = await fetch(`${API}/GetListOfMovies`);
  const data = await res.json();
  container.innerHTML = data.map(renderMovieCard).join('');
}

function editMovie(id) {
  fetch(`${API}/GetListOfMovies`)
    .then(res => res.json())
    .then(data => {
      const movie = data.find(m => m.idMovie === id);
      if (!movie) return;

      document.getElementById('idMovie').value = movie.idMovie;
      document.getElementById('title').value = movie.title;
      document.getElementById('releaseYear').value = movie.releaseYear;
      document.getElementById('genre').value = movie.genre;
      document.getElementById('director').value = movie.director;
      document.getElementById('rate').value = movie.rate;
      document.getElementById('movieUrl').value = movie.movieUrl;
      document.getElementById('trailerUrl').value = movie.trailerUrl;

      isEditing = true;
    });
}

async function deleteMovie(id) {
  if (!confirm('Are you sure you want to delete this movie?')) return;
  await fetch(`${API}/DeleteMovies?id=${id}`, { method: 'DELETE' });
  loadMovies();
}

loadMovies();
