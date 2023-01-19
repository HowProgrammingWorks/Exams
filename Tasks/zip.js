// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zip = function (array1 = [], array2 = []) {
  let i = 0;
  j = 0;
  for (x of b) {
    CELL = [array1[i++], x];
    if (i < j) {
      delete array1[i++];
    } else {
      (() => (array2[j++] = CELL))();
    }
    if (CELL[0] == undefined) b.length -= 1
  }
  return b;
};

require('../Tests/zip.js')(zip);
