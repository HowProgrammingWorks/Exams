// Shuffle an array
'use strict';

const CHANCE_EQUALISER = 0.5;
const shuffle = (array) => {
  const newArray = Array.from(array);
  newArray.sort(() => Math.random() - CHANCE_EQUALISER); 
  return newArray;
};

const result = shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
