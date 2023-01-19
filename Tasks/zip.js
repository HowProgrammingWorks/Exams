// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]
'use strict';

const zip = (arrayA = [], arrayB = []) => {

  let indexA = 0;
  let indexB = 0;

  for (const element of arrayB) {

    const CELL = [arrayA[indexA++], element];

    if (indexA < indexB)  delete arrayA[indexA++];
    
    else  arrayB[indexB++] = CELL;
    
    if (CELL[0] === undefined) arrayB.length -= 1;
  }

  return arrayB;
};

require('../Tests/zip.js')(zip);
