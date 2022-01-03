// Merge two dictionaries

"use strict";

const mergeTwoObjects = (object_1, object_2) => {
  const object_3 = {};
  for (const key in object_1) {
    object_3[key] = object_1[key];
  }
  for (const key in object_2) {
    object_3[key] = object_2[key];
  }
  return object_3;
};

const result = mergeTwoObjects({ a: "uno", b: "due" }, { c: "tre" });
console.log(result);
