"use strict";

// Return an array without duplicates

const distinct = (data) => {
  const set = new Set();
  let iteration = 0;
  data.forEach((element) => {
    if (set.has(element)) {
      data.splice(iteration, 1);
    } else {
      set.add(element);
    }
    iteration++;
  });
  return data;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
