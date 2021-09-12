  
const button = document.querySelector('.weatherlist');
const listofweathers = document.querySelector('.listofweathers');

button.addEventListener('click', (e) => {

  fetch('WeatherForecast')
  .then(res => {
    if (!res.ok) {
      console.log('NOT OK')
      throw new Error(`Network response was not ok (${res.status})`);
    }
    else {
      return res.json();
    }
  })
  .then(res => {
    console.log(res);
 
    for (let x = 0; x < res.length;x++) {
      listofweathers.innerText += `The temp is ${res[x].temperatureC}.\nThe weather is ${res[x].summary}.\n`
    }
  })
    .catch(err => console.log(`There was an error ${err}`));
});