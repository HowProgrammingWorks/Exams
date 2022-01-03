"use strict";
// Copy all values from dict except listed

const copyAllExcept = (object, ...except) => {
  const resObject = {};

  for (let [key,value] of Object.entries(object)) {
    if (!except.includes(key)) { 
      resObject[key] = value;
    }
  }
   return resObject;
};

const result = copyAllExcept({ a: 1, b: "two", c: 3, d: 4 }, "a", "d");
console.log(result);
