// // Sum all numbers from array
'use strict'
function sum (s) {
 let summ = 0
 for (let i of s) {
 let t = typeof i;
  if (t === 'number'){
    summ  += i 
 }  
 };
 return summ
}
const result = sum([5, true, 'string', 7, 'hello']);
console.log(result);
