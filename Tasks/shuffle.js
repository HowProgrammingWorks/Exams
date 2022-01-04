// Shuffle an array
'use strict';
let Shuffle = (arr) => {
  arr.sort(() => Math.random() - 0.5); 
  return arr;
};

const result = Shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
