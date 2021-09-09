//running in console now

//1.create teh objc that use to make request
let xhr = new XMLHttpRequest();

//2.do sth if res is received
//ccccccccccccccccccccccccccc

// function PrintJoke(){

//   console.log(`onreadystatechange was fires. ${this.readyState}`)
//   if(this.status == 200 && this.readyState ==4){

//     //prints out the content using responseTex
//     //want specifi result
//     //When receiving data from a web server, the data is always a string.
//     //Parse the data with JSON.parse(), and the data becomes a JavaScript object.
//     const result = JSON.parse(this.responseText);
// console.log(`the request was successful, what you get is ${result.value.joke}`);

// //put it to the html tag <p></p>
// //return the first ele that is a desandent of node that matcheds
// const para = document.querySelector('p');
// //put the joke inside the innerHTML of p
// para.innerHTML = result.value.joke;
//   }else if(this.status != 200 && this.readyState ==4){
//     console.log(`not successful, ${this.status}`);
//   }
// }




xhr.onreadystatechange = PrintJokes;
function PrintJokes(){
    if(this.status == 200 && this.readyState ==4){

     //prints out the content using responseTex
      //want specifi result
    //When receiving data from a web server, the data is always a string.
    const result = JSON.parse(this.responseText);
  // console.log(`the request was successful, what you get is ${result.value.joke}`);
    const body = document.querySelector('body');
    for( let i = 0; i<result.value.length;i++){
body.innerHTML += `<li> ${result.value[i].joke}</li>`
    }

    // //put it to the html tag <p></p>
    // //return the first ele that is a desandent of node that matcheds
  //  const para = document.querySelector('p');
  //   // //put the joke inside the innerHTML of p
  //   para.innerHTML = result.value.joke;
      }else if(this.status != 200 && this.readyState ==4){
         console.log(`not successful, ${this.status}`);
    }
}



//3 open connection to the api you wan to get data from an address
// xhr.open('GET',"http://api.icndb.com/jokes/random",true);

xhr.open('GET',"http://api.icndb.com/jokes/random/5",true);


//4.send the request
xhr.send();