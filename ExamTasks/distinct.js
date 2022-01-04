"use strict";
// Deduplicate values in array

const distinct = (arr) => {
  const set = new Set();
  let spliceIndex = 0;
  for (const arrElement of arr) {
    if (set.has(arrElement)) {
      arr.splice(spliceIndex, 1);
    } else {
      set.add(arrElement);
    }
    spliceIndex++;
  }

  return arr;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);


// Solving the task in one line

// const distinct = (arr) => [...new Set(arr)]
// const result = distinct([1, 2, 1, 3, 1, 4]);
//  console.log(result);