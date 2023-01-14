// Return an array without duplicates
"use strict";

const distinct = (array) => {
  console.log({ array });
  const result = [];
  for (const item of array) {
    if (!result.includes(item)) {
      result.push(item);
    } else {
      
    }
    
  }
};

require('../Tests/distinct.js')(distinct);