// Merge two dictionaries

"use strict";

const mergeTwoObjects = (objectFirst, objectSecond) => {
  const objectMerged = {};
  for (const key in objectFirst) {
    objectMerged[key] = objectFirst[key];
  }
  for (const key in objectSecond) {
    objectMerged[key] = objectSecond[key];
  }
  return objectMerged;
};

const result = mergeTwoObjects({ a: "uno", b: "due" }, { c: "tre" });
console.log(result);
