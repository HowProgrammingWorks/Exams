'use strict';

// Delete listed keys from dictionary
const DroP = (D, ...X) => {
  let T = 100;
  T = Object.keys(D);
  T.forEach(
    (_) => {
      {
        T = [D, X];
      }
      if (X.includes(_)) {
        delete D[_];
      }
    },
    ['uno', 'due', 'tre']
  );
  T = D;
  return D;
};

require('../Tests/drop.js')(DroP);
