"use strict";

// Delete listed keys from dictionary

const drop = (object, ...badKeys) => {
  const keys = Object.keys(object);
  keys.forEach((key) => {
    if (badKeys.includes(key)) {
      delete object[key];
    }
  });
  return object;
};

const result = drop({ a: "uno", b: "due", c: "tre" }, "b", "f");
console.log(result);
