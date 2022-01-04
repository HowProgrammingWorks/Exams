// Remove values from array
'use strict';
const Skip = (arr, ...Remove) => {
  let x = 0;
  for (const elem of arr) {
    for (const val of Remove) {
      if (elem === val) {
        arr.splice(x, 1);
      }
    }
  x++;
  }
return arr;
}

const result = Skip([1, 2, 3, 4, 5], 2, 5);
console.log(result);
