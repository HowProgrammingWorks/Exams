// Copy all values from dict except listed

'use strict';

const EXCEPT = (incomingvaluesarray, ...no) => {
  const copiedIncomingvaluesarray = {};
  const intermediate_variable = Object.keys(incomingvaluesarray);
  for (const Z of intermediate_variable) {
    if (!no.includes(Z)) {
      copiedIncomingvaluesarray[Z] = incomingvaluesarray[Z];
    }
  }
  return copiedIncomingvaluesarray;
};

require('../Tests/except.js')(EXCEPT);
