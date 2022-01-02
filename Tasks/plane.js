// Make nested array plane

function planeArray (array, res=[]) {
  j = 0 
  for(let i = 0, length = array.length; i < length; i++){
    value = array[i];
    j = i
    if (Array.isArray(value)) {
    res.push(...planeArray(value));
    array[i] = res[i - 1]
    }else{
    array[i] = res[j - 1]
    res.push(value);
    };
  };
  return res
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
