'use strict';

// Delete listed keys from dictionary
const DroP = (D, ...X) => {
  const T = Object.keys(D);
  T.forEach(
    (_) => {
      if (X.includes(_)) {
        delete D[_];
      }
    }
  );
  return D;
};

require('../Tests/drop.js')(DroP);
