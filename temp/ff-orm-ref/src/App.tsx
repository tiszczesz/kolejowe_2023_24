
import { FormEvent, useRef, useState } from 'react';
import './App.css';

function App() {

  const refA = useRef<HTMLInputElement>(null);
  const refB = useRef<HTMLInputElement>(null);
  const [dane,setDane] = useState<{a:string,b:string}>({a:"",b:""})
  

  //  pierwszy sposób --------
  // const [a,setA] = useState("");
  // const [b,setB] = useState("");
  // function handleSubmit(event: FormEvent<HTMLFormElement>): void {
  //   event.preventDefault();
  //   if(refA.current!==null && refB.current!==null){
  //       setA((value)=>(refA.current?.value??"")
  //       )
  //       setB((value)=>refB.current?.value??"")
  //       console.log(a,b);
          
  //   }
  // }
  // ---- drugi sposób
  function handleSubmit(event: FormEvent<HTMLFormElement>): void {
    event.preventDefault();
    const aa = refA.current?.value??"";
    const bb = refB.current?.value??"";
    setDane(prev=>({...prev,a:aa,b:bb}))
  }

  return (
    <div>
     <form onSubmit={handleSubmit} >
      
      <div>
        <input ref={refA} type="text" name="a" id="a" placeholder='a' />
      </div>
      <div>
        <input ref={refB} type="text" name="b" id="b"  placeholder='b'/>
      </div>
      <input type="submit" value="Zapisz" />
     </form>
     <div>
      a = {dane.a} <br />
      b = {dane.b} 
      </div>
    </div>
  );
}

export default App;
