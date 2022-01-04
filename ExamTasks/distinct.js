'use strict'
// Deduplicate values in array

const distinct = (arr) => {
    const set = new Set(); 
    let spliceIndex = 0;
    arr.forEach((arrElement) => {
        if (set.has(arrElement)) {
        arr.splice(spliceIndex, 1)
        } else {
        set.add(arrElement)
        };
        spliceIndex++;
    });
  return arr;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
