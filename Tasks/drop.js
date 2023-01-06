// Delete listed keys from dictionary

// Step 1
// Add 'use strict';
// Remove useless condition, blocks and assignments

'use strict';

DroP = (D, ...X) => {
  T = Object.keys(D);
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
