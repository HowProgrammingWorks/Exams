// Shuffle an array
const array = [1,2,3,4,5]
  const shuffle = function (arr){
    for (let i = arr.length - 1; i > 0; i--){
      const current = arr [i];
      const random = Math.floor(Math.random() * (i + 1));
      
      arr[i] = arr [random]
      arr[random] = current;
    }
    return arr;
  }
  
  for (let i = 0; 1 < 5; i++) {
    console.log(shuffle(array).join(*,*))
  }

require('../Tests/shuffle.js')(Shuffle);
