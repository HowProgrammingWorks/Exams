// Merge two dictionaries

"use strict";

const mergeTwoObjects = (objectFirst, objectSecond) => {
  const objectMerged = {};
  const keysFirst = Object.keys(objectFirst);
  const keysSecond = Object.keys(objectSecond);
  for (const key of keysFirst) {
    objectMerged[key] = objectFirst[key];
  }
  for (const key of keysSecond) {
    objectMerged[key] = objectSecond[key];
  }
  return objectMerged;
};

const result = mergeTwoObjects({ a: "uno", b: "due" }, { c: "tre" });
console.log(result);
