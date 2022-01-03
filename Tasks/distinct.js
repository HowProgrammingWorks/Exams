// Deduplicate values in array

eaveUniqueValues = function(array) {
  arrayForIfElse=[]; startSpl=0;
    array.forEach((elem) => {
        if (arrayForIfElse.includes(elem)) {
        array.splice(startSpl, 1);
        } else {
         arrayForIfElse.push(elem);
        };
        startSpl++;
    });
  return array;};

const result = eaveUniqueValues([1, 2, 1, 3, 1, 4]);
console.log(result);
