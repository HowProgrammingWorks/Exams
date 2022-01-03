// Remove values from array
//'use strict';

const skipElements = (T, ...Remove) => {
  for (let i = 0; i < T.length; i++) {
    for (X of Remove) {
      if (T[i] === X) {
        T.splice(i, 1);
      }
    }
  }
  return T;
};

const result = skipElements([1, 2, 3, 4, 5], 2, 5);
console.log(result);
