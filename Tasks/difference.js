// Finde a difference of two dictionaries

"use strict";
const difference = (obj1, obj2) => {
    let diffObj = { ...obj1 };
    for (const key in obj2) {
      diffObj[key] = obj2[key];
      delete diffObj[key];
    }
    return diffObj;
  };
const result = difference({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);
