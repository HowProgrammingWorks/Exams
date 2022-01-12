// Shuffle an array
'use strict';

let  Shuffle = ( ...List) => {
  const [ arr ] = List;
  return arr.sort(() => Math.random() - 0.5);
}
const result = Shuffle(['a', 'b', 'c', 'd', 'e']);
console.log(result);
