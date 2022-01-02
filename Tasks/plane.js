// Make nested array plane

const plane = function(arr){
  if(!plane.res) plane.res = [];
  for(let item of arr){
    if (Array.isArray(item)) plane(item);
    else plane.res.push(item);
  }
  return plane.res
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
