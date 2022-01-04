// Split array into two parts

const splitArray=(index,array)=>{
  const part1=array.slice(0,index);
 const  part2=array.slice(index,array.length);
    return [part1 ,part2];
};

const result = splitArray(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
