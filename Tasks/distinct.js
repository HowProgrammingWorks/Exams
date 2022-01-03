// Deduplicate values in array

eaveUniqueValues = function(array) {
  uniqueSet=new Set(); startSpl=0;
    array.forEach((elem) => {
        if (uniqueSet.has(elem)) {
        array.splice(startSpl, 1);
        } else {
          uniqueSet.add(elem);
        };
        startSpl++;
    });
  return array;};

const result = eaveUniqueValues([1, 2, 1, 3, 1, 4]);
console.log(result);
