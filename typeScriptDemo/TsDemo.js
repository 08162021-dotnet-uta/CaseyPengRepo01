//take 2 objects that have string arrays and alternately print them out to the console
function AlternatingStrings(obj1, obj2) {
    //find the smaller arrays
    let smallerArray = Math.min(obj1.stringArray.length, obj2.stringArray1.length);
    let fullString = '';
    for (let i = 0; i < smallerArray; i++) {
        fullString = `${obj1.stringArray[i]} ${obj2.stringArray1[i]}`;
    }
    return fullString;
}
let myObj1 = { stringArray: ["This", "a", "cool", "demo"], bigNumber: 12345678965412362n, currentDate: new Date() };
let myObj2 = { stringArray1: ["is", "really", "TypeScript", "."], isTrueOrFalse: true, integer: 100 };
let resultStirng = AlternatingStrings(myObj1, myObj2);
console.log(resultStirng  +"abvc");
