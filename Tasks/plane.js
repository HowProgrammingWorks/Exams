// Make nested array plane

const_plane = function(arr, res=[]) {
  for(let value of arr){
    if (Array.isArray(value)) {
    res.push(...const_plane(value));
    }else{
    res.push(value);
    }
  }
  return res
}

const result = const_plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
