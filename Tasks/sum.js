//Step 4
"use strict";
const sum = (argArray) => {
  const res = [0];
  argArray.map((arrayElem) => {
    if (typeof arrayElem === "number") {
     res.push(res[res.length - 1] + arrayElem);
      }
    });
    if (res.length === 0) 0;
  return res[res.length - 1];
};

require('../Tests/sum.js')(sum);