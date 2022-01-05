'use strict'

// Deduplicate values in array

const distinct = (data) => {
  const arrayOfSet = new Set();
  for (let c = data.length; c >= 0; c--) {
    const arrElem = data[c];
    if (arrayOfSet.has(arrElem)) {
      data.splice(c, 1);
    } else {
      arrayOfSet.add(arrElem);
    }
 }
  return data;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
