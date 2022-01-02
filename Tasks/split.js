// Split array into two parts

let split_Array=(index,array)=>{
  begin=array.slice(0,index)
    const len=array.length;
  array=array.slice(index,len)
    return [begin,array]
}

const result = split_Array(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
