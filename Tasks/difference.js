// Finde a difference of two dictionaries

"use strict";

const diff = (object_1, object_2) => {
  for (const key in object_2) {
    object_1[key] = object_2[key];
    delete object_1[key];
  }
  return object_1;
};

const result = diff({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);
