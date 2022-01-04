"use strict";
// Copy all values from dict except listed

const copyAllExcept = (object, ...except) => {
  const resObject = {};
  const keys = Object.keys(object);
  for (const key of keys) {
    if (!except.includes(key)) { 
      resObject[key] = object[key];
    }
  }
   return resObject;
};

const result = copyAllExcept({ a: 1, b: "two", c: 3, d: 4 }, "a", "d");
console.log(result);
