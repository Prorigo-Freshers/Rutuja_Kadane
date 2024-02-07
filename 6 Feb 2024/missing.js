
//Problem Description no. 1 :.Find the first missing number from array using javascript


//Input = [9, 5, 6, 4, 1, 2, 7, 8];
Output : 3

let n = [5,7,8,6,1,3];
let result = [];
for(let val of n ) {
   result[val]=true;
}
for(let i = 1 ; i< n.length;i++)
{
    if(!result[i])
    {
        console.log(i);
    }
}