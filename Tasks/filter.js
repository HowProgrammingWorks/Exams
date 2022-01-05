// Filter array by type name

'use strict';

const Filter = (T, t) => {
  for (let C of T) {
    let x = T.indexOf(C);
    if (typeof T[x] !== t) { T.splice(x, 1); }
  }
  return T;
};
  
const result = Filter([1, 2, 'three', 4, 5, 'six'], 'number');
console.log(result);
