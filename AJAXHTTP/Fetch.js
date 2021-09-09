//using fetch
// fetch("http://api.icndb.com/jokes/random/5",)
// .then(res=>res.json())
// .then(res=>{
//   console.log(res)
//   return res;
// }).then(
//   res =>{
//     // const body = document.querySelector('body');
//     for(let i=0;i<res.value.length;i++){
//       const ele = document.getElementById(`${i+1}`)
//     //   body.innerHTML +=`<p >${res.value[i].joke}</p>`

//     ele.innerHTML = res.value[i].joke;
//     }
//     console.log(this.responseText);
//   }
// )
//other way of geting all the tab by tag Name

const allPeles = document.getElementsByTagName("p");
fetch("http://api.icndb.com/jokes/random/5",)
.then(res=>res.json())
.then(res=>{
  console.log(res)
  return res;
}).then(
  res =>{
    // const body = document.querySelector('body');
    for(let i=0;i<res.value.length;i++){
 allPeles[i].innerHTML= res.value[i].joke;
    }
    console.log(this.responseText);
  }
)