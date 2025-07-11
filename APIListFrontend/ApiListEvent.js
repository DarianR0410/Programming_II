let totalRequests = 0;
let successfulRequests = 0;
let totalAnimals = 0;
let totalPeople = 0;

function updateStats() {
    document.getElementById('total-animals').textContent = totalAnimals;
    document.getElementById('total-people').textContent = totalPeople;
    document.getElementById('total-requests').textContent = totalRequests;
    const successRate = totalRequests > 0 ? Math.round((successfulRequests / totalRequests) * 100) : 100;
    document.getElementById('success-rate').textContent = successRate + '%';
}

function showLoading(type) {
    const spinner = document.getElementById(`${type}-spinner`);
    const button = document.querySelector(`[onclick="fetch${type.charAt(0).toUpperCase() + type.slice(1)}()"]`);
    
    spinner.style.display = 'inline-block';
    button.classList.add('loading');
}

function hideLoading(type) {
    const spinner = document.getElementById(`${type}-spinner`);
    const button = document.querySelector(`[onclick="fetch${type.charAt(0).toUpperCase() + type.slice(1)}()"]`);
    
    spinner.style.display = 'none';
    button.classList.remove('loading');
}

function showError(type, message) {
    const errorDiv = document.getElementById(`${type}-error`);
    errorDiv.textContent = message;
    errorDiv.style.display = 'block';
    
    setTimeout(() => {
        errorDiv.style.display = 'none';
    }, 5000);
}

function displayResults(type, data) {
    const resultsContainer = document.getElementById(`${type}-results`);
    const resultsGrid = document.getElementById(`${type}-grid`);
    const countElement = document.getElementById(`${type}-count`);
    
    resultsContainer.style.display = 'block';
    resultsGrid.innerHTML = '';
    
    if (Array.isArray(data)) {
        countElement.textContent = `${data.length} items`;
        
        data.forEach((item, index) => {
            const resultItem = document.createElement('div');
            resultItem.className = 'result-item';
            resultItem.innerHTML = `
                <strong>${type.charAt(0).toUpperCase() + type.slice(1)} #${index + 1}</strong>
                <pre>${JSON.stringify(item, null, 2)}</pre>
            `;
            resultsGrid.appendChild(resultItem);
        });
        
        if (type === 'animals') {
            totalAnimals = data.length;
        } else {
            totalPeople = data.length;
        }
    } else {
        countElement.textContent = '1 item';
        const resultItem = document.createElement('div');
        resultItem.className = 'result-item';
        resultItem.innerHTML = `
            <strong>${type.charAt(0).toUpperCase() + type.slice(1)} Data</strong>
            <pre>${JSON.stringify(data, null, 2)}</pre>
        `;
        resultsGrid.appendChild(resultItem);
        
        if (type === 'animals') {
            totalAnimals = 1;
        } else {
            totalPeople = 1;
        }
    }
    
    updateStats();
}

async function fetchAnimals() {
    showLoading('animals');
    totalRequests++;
    
    try {
        const url = "http://localhost:5270/api/Animal/Get_Animal";
        const response = await fetch(url);
        
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        const data = await response.json();
        successfulRequests++;
        displayResults('animals', data);
        console.log('Animals data:', data);
        
    } catch (error) {
        console.error('Error fetching animals:', error);
        showError('animals', `Failed to fetch animals: ${error.message}`);
    } finally {
        hideLoading('animals');
        updateStats();
    }
}

async function fetchPeople() {
    showLoading('people');
    totalRequests++;
    
    try {
        const url = "http://localhost:5270/api/People/GetPeople";
        const response = await fetch(url);
        
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        const data = await response.json();
        successfulRequests++;
        displayResults('people', data);
        console.log('People data:', data);
        
    } catch (error) {
        console.error('Error fetching people:', error);
        showError('people', `Failed to fetch people: ${error.message}`);
    } finally {
        hideLoading('people');
        updateStats();
    }
}

// Initialize stats on page load
document.addEventListener('DOMContentLoaded', function() {
    updateStats();
});