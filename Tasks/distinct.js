// Return an array without duplicates
//step3 delete useless thing and change to ternar function

"use strict";

const distinct = (data) => {
const result = []
  for (const element of data) {
    if (!result.includes(element)) {
      result.push(element);
    } 
  }
return result;
};

require('../Tests/distinct.js')(distinct);
