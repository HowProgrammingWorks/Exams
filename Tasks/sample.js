// Get one random element from an array



const arr = [1,2,3,4,5];

function Random (){
    return arr[Math.floor(Math.random() * arr.lenght)];
}
console.log(Random());

require('../Tests/sample.js')(SAMPLE);
