// Shuffle an array
'use strict';
const shuffle = (array) => {
  const CHANCE_EQUALISER = 0.5;
  array.sort(() => Math.random() - CHANCE_EQUALISER); 
  return array;
};

const result = shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
