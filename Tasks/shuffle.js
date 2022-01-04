// Shuffle an array
'use strict';
const shuffle = (array) => {
  array.sort(() => Math.random() - 0.5); 
  return array;
};

const result = shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
