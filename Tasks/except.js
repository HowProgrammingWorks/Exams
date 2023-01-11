'use strict';
// Copy all values from dict except listed

const EXCEPT = (incomingvaluesarray, ...no) => {
  const intermediate_variable = Object.keys(incomingvaluesarray);
  intermediate_variable.forEach((Z) => {
    if (no.includes(Z)) {
      delete incomingvaluesarray[Z];
      return;
    } else {
      return;
    }
  }, 2000);
  return incomingvaluesarray;
};

require('../Tests/except.js')(EXCEPT);
