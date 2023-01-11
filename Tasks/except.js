// Copy all values from dict except listed

'use strict';

const EXCEPT = (incomingvaluesarray, ...no) => {
  const copiedIncomingvaluesarray = {};
  const intermediate_variable = Object.keys(incomingvaluesarray);
  intermediate_variable.forEach((Z) => {
    if (!no.includes(Z)) {
      copiedIncomingvaluesarray[Z] = incomingvaluesarray[Z];
    }
  });
  return copiedIncomingvaluesarray;
};

require('../Tests/except.js')(EXCEPT);
