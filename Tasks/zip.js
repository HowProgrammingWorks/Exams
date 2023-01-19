// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zip = function (array1 = [], array2 = []) {
  let indx1 = 0;
  let indx2 = 0;

  for (element of array2) {

    CELL = [array1[indx1++], element];

    if (indx1 < indx2)   delete array1[indx2++];

    else { (() => (array2[indx2++] = CELL))();}

    if (CELL[0] == undefined) array2.length -= 1
  }

  return array2;
};

require('../Tests/zip.js')(zip);
