fetch('https://https://localhost:7202/WeatherForecast')
  .then(response => response.json())
  .then(data => console.log(data));