'use strict';

const EXCEPT = (incomingvaluesarray, ...no) => {
const intermediate_variable = Object.keys(incomingvaluesarray);
  for (const Z of intermediate_variable) {
    if (no.includes(Z)) {
      delete incomingvaluesarray[Z];
    }
  }
  return incomingvaluesarray;
};

require('../Tests/except.js')(EXCEPT);
