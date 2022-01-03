// Finde a difference of two dictionaries

"use strict";
const difference = (object_1, object_2) => {
    for (const attribute_name in object_2) {
      object_1[attribute_name] = object_2[attribute_name];
      delete object_1[attribute_name];
    }
    return object_1;
  };
const result = difference({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);
