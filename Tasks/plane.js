// Make nested array plane

function planeArray (array, res=[]) {
  
  for(let index in array){
    value = array[index];
    
    if (Array.isArray(value)) {
    res.push(...planeArray(value));
    array[index] = res[index - 1]
    }else{
    array[index] = res[index - 1]
    res.push(value);
    };
  };
  return res
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
