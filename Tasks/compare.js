// Compare two dictionaries
"use strict";

const compareDictionaries = function (obj1, obj2) {
  const arr1 = Object.keys(obj1).sort();
  const arr2 = Object.keys(obj2).sort();
  let e = true;

  if (arr1.length !== arr2.length) return false;

  for (let i = 0; i < arr1.length; i++) {
    if (arr1[i] !== arr2[i]) return false;
  }

  for (const key of arr1) {
    if (obj1[key] !== obj2[key]) e = false;
  }

  return e;
};

const result = compareDictionaries({ a: 1, c: "hello" }, { a: 1, c: "hello" });
console.log(result);
