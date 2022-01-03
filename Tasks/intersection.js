'use strict';
// Find an intersection of two dictionaries

const intersection = (object_1, object_2) => {
    const key = Object.keys(object_1);
    for (const attribute_name of key) {
      if (attribute_name !== "" && object_2[attribute_name]) {
        object_2[attribute_name] = object_1[attribute_name];
      } else {
        delete object_1[attribute_name];
      }
    }
    return object_1;
  }
  const result = intersection({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
  console.log(result);