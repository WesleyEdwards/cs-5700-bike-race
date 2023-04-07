var Y=Object.defineProperty;var F=(e,t,i)=>t in e?Y(e,t,{enumerable:!0,configurable:!0,writable:!0,value:i}):e[t]=i;var o=(e,t,i)=>(F(e,typeof t!="symbol"?t+"":t,i),i);(function(){const t=document.createElement("link").relList;if(t&&t.supports&&t.supports("modulepreload"))return;for(const s of document.querySelectorAll('link[rel="modulepreload"]'))n(s);new MutationObserver(s=>{for(const r of s)if(r.type==="childList")for(const c of r.addedNodes)c.tagName==="LINK"&&c.rel==="modulepreload"&&n(c)}).observe(document,{childList:!0,subtree:!0});function i(s){const r={};return s.integrity&&(r.integrity=s.integrity),s.referrerpolicy&&(r.referrerPolicy=s.referrerpolicy),s.crossorigin==="use-credentials"?r.credentials="include":s.crossorigin==="anonymous"?r.credentials="omit":r.credentials="same-origin",r}function n(s){if(s.ep)return;s.ep=!0;const r=i(s);fetch(s.href,r)}})();const N={left:!1,right:!1,escape:!1,shoot:!1},L=150,p=576,x=p+2*L,g=576,T=10,u=L,D=x-L,O=T,H=.3,E=25,w=g-E*1.5,W=p-T-E,d=100,M=25,G=.15,C=.05,X=1e3,b=3,$=40,q=2;function K(){const e=document.createElement("canvas");e.setAttribute("id","canvas");const t=e.getContext("2d");return{canvas:e,context:t}}function V(e,t){const i=document.getElementById("mainDiv");e.height=g,e.width=x,y("mainMenu","Main Menu",t).setAttribute("style","margin-top: 2rem;"),i.appendChild(e)}function y(e,t,i){const n=document.createElement("button");return n.setAttribute("id",e),n.innerHTML=t,n.addEventListener("click",i),n}function S(e){const t=document.createElement("h1");t.setAttribute("class","onBackground"),t.innerHTML="Midterm";const i=J("mainDiv");i.appendChild(t),i.appendChild(e??document.createElement("div"));const n=document.getElementById("app");n.innerHTML="",n.appendChild(i)}function J(e){const t=document.createElement("div");return t.setAttribute("id",e),t}class Z{constructor(t,i,n){o(this,"context");o(this,"yPos");o(this,"xPos");o(this,"color","white");o(this,"velX");o(this,"velY");this.context=t,this.yPos=n,this.xPos=i,this.velX=Math.random()*2-1,this.velY=Math.random()*2-1}draw(){this.context.fillStyle=this.color,this.context.fillRect(u+this.xPos,this.yPos,b,b)}update(t){this.yPos+=C*t*this.velY,this.xPos+=C*t*this.velX,this.velX*=.99,this.velY*=.99}}function j(e){window.addEventListener("keydown",({key:t})=>{t==="ArrowRight"&&(e.right=!0),t==="ArrowLeft"&&(e.left=!0),t==="Escape"&&(e.escape=!0)}),window.addEventListener("keyup",({key:t})=>{t==="ArrowRight"&&(e.right=!1),t==="ArrowLeft"&&(e.left=!1)})}function U(e,t){const i=[];for(let n=0;n<100;n++)i.push(new Z(e,t+Math.random()*30,w+Math.random()*30));return i}const B={player:"https://steamuserimages-a.akamaihd.net/ugc/3336348870692605210/2DB65000D1AE5B34BCEC2E3E91A27537B3EFC057/?imw=268&imh=268&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true",background:"https://images.unsplash.com/photo-1445905595283-21f8ae8a33d2?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8M3x8fGVufDB8fHx8&w=1000&q=80",leftBg:"https://images.unsplash.com/photo-1534796636912-3b95b3ab5986?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8MXx8fGVufDB8fHx8&w=1000&q=80",rightBg:"https://images.hdqwalls.com/download/nebula-space-scifi-4k-l7-1366x768.jpg"},f={border:"green",timerBg:"black",timerText:"white",block:"#DE3163",readyBlock:"#FF7F50",loseText:"red"},k=["#FFBF00","#DFFF00","#FF7F50","#DE3163"];class z{constructor(t){o(this,"pos",p/2);o(this,"moving","none");o(this,"context");this.context=t}update(t,i){t.left&&(this.movePlayer("left",i),this.moving="left"),t.right&&(this.movePlayer("right",i),this.moving="right"),this.moving==="left"&&!t.left&&(this.moving="none"),this.moving==="right"&&!t.right&&(this.moving="none")}movePlayer(t,i){t==="left"&&this.pos>O&&(this.pos-=H*i),t==="right"&&this.pos<W&&(this.pos+=H*i)}draw(){const t=new Image;t.src=B.player,this.context.drawImage(t,u+this.pos,w,E,E)}}class Q{constructor(t,i,n){o(this,"context");o(this,"yPos");o(this,"xPos");o(this,"color");this.context=t,this.yPos=n,this.xPos=i,this.color=k[Math.floor(Math.random()*k.length)]}draw(){this.context.fillStyle=this.color,this.context.fillRect(u+this.xPos,this.yPos,b,b)}update(t){this.yPos+=C*t}}class tt{constructor(t){o(this,"context");o(this,"particles",[]);this.context=t}draw(){this.particles.forEach(t=>t.draw())}update(t,i,n){for(let s=0;s<this.particles.length;s++)this.particles[s].update(t);for(let s=0;s<this.particles.length;s++)(this.particles[s].yPos<n-$||Math.random()<.1)&&(this.particles.splice(s,1),s--);this.particles.push(...et(this.context,t,i,n))}}function et(e,t,i,n){const s=[];for(let r=0;r<Math.floor(q*t);r++){const c=Math.floor(Math.random()*p);if(c>i&&c<i+d)continue;const l=new Q(e,c,n);s.push(l)}return s}class R{constructor(t,i){o(this,"posY");o(this,"emptySpace");o(this,"context");o(this,"particles");this.posY=0,this.emptySpace=it(i),this.context=t,this.particles=new tt(t)}draw(t=!1){this.context.fillStyle=t?f.readyBlock:f.block,this.context.fillRect(u,this.posY,this.emptySpace,M),this.context.fillRect(u+this.emptySpace+d,this.posY,p-this.emptySpace-d,M),this.particles.draw()}update(t){this.posY+=G*t,this.particles.update(t,this.emptySpace,this.posY)}}function it(e){const t=Math.floor(Math.random()*(d*.75-d*.15)+d*.15);return e-t<0?t:e+t>p-d||Math.random()>.5?e-t:e+t}class st{constructor(t){o(this,"blocks",[]);o(this,"upNext");o(this,"timeSinceLast",0);o(this,"context");this.upNext=new R(t,p/2),this.context=t}draw(){this.upNext.draw(!0),this.blocks.forEach(t=>t.draw())}update(t){if(this.timeSinceLast+=t,this.blocks.forEach(i=>{i.update(t),i.posY>600&&this.blocks.shift()}),this.timeSinceLast>X){const i=this.upNext.emptySpace;this.blocks.push(this.upNext),this.upNext=new R(this.context,i),this.timeSinceLast=0}}checkCollision(t){if(this.blocks.length===0)return!1;const i=this.blocks[0];return i.posY+M>w&&i.posY<w+E&&(t<i.emptySpace||t+E>i.emptySpace+d)}}const nt=(()=>{const e=new Image;return e.src=B.background,e})(),ot=(()=>{const e=new Image;return e.src=B.leftBg,e})(),rt=(()=>{const e=new Image;return e.src=B.rightBg,e})();function ct(e,t){e.drawImage(rt,0,0,x,g),e.drawImage(ot,0,0,u,g),e.drawImage(nt,u,0,x-2*L,g),e.fillStyle=f.timerBg,e.fillRect(D+20,20,100,50),e.fillStyle=f.timerText,e.font="30px Arial",e.fillText(`${Math.round(t/10)/100}`,D+25,60,100)}function lt(e){e.strokeStyle=f.border,e.lineWidth=T,e.strokeRect(u,0,x-u*2,g)}class at{constructor(t){o(this,"keys",N);o(this,"player");o(this,"context");o(this,"blocks");o(this,"totalTime",0);o(this,"lostParticles",null);j(this.keys),this.player=new z(t),this.blocks=new st(t),this.context=t}updateAll(t,i){if(this.blocks.checkCollision(this.player.pos)&&this.lostParticles===null&&(this.lostParticles=U(this.context,this.player.pos)),this.keys.escape&&(i(Math.round(this.totalTime/10)/100),this.keys.escape=!1),this.lostParticles!==null){this.lostParticles.forEach(n=>n.update(t));return}this.totalTime+=t,this.player.update(this.keys,t),this.blocks.update(t)}drawAll(){ct(this.context,this.totalTime),this.lostParticles===null?this.player.draw():this.lostParticles.forEach(t=>t.draw()),this.blocks.draw(),lt(this.context),this.lostParticles!==null&&(this.context.fillStyle=f.timerBg,this.context.fillRect(300-35,300-35,420,100),this.context.fillStyle=f.loseText,this.context.font="30px Arial",this.context.fillText("You Lost!",300,300),this.context.font="20px Arial",this.context.fillText("Press 'escape' to return to the main menu",300,350))}}function ht(e,t){const i=I(),n=i.length===0?0:Math.max(...i);i.push(e),i.sort((A,P)=>P-A),i.length>5&&i.shift(),ut(i);const s=e>n?`You got a new High Score of ${e}!`:`Score: ${e}`,r=document.createElement("h2");r.setAttribute("id","congrats"),r.innerHTML=s;const c=document.createElement("div");c.setAttribute("id","highScoreDiv");const l=document.createElement("h3");l.innerHTML="High Scores",c.appendChild(l),i.forEach((A,P)=>{const h=document.createElement("div");h.innerHTML=`${P+1}: ${A}`,c.appendChild(h)});const a=document.createElement("div");a.setAttribute("class","infoContainer onBackground");const m=y("playAgain","Play Again",t);a.appendChild(r),a.appendChild(c),a.appendChild(m),S(a)}function I(){const e=localStorage.getItem("midterm-scores");return e?JSON.parse(e):[]}function ut(e){localStorage.setItem("midterm-scores",JSON.stringify(e))}function v(e,t){S();const i=()=>{var c,l;e(),(c=document.getElementById("gameSetup"))==null||c.remove(),(l=document.getElementById("instructions"))==null||l.remove()},n=document.createElement("h2");n.setAttribute("id","instructions"),n.innerHTML="Press play to begin.";const s=document.createElement("div");s.setAttribute("id","gameSetup"),s.setAttribute("class","infoContainer onBackground"),s.appendChild(n);const r=y("play-button","Play",i);if(s.appendChild(r),t){const c=y("high-scores-button","High Scores",t);s.appendChild(c)}S(s)}function dt(e){const t=I(),i=document.createElement("div");i.setAttribute("id","highScoreDiv");const n=document.createElement("h3");if(n.innerHTML="High Scores",i.appendChild(n),t.length===0){const c=document.createElement("div");c.innerHTML="No Scores Yet",i.appendChild(c)}t.forEach((c,l)=>{const a=document.createElement("div");a.innerHTML=`${l+1}: ${c}`,i.appendChild(a)});const s=document.createElement("div");s.setAttribute("class","infoContainer onBackground");const r=y("playAgain","Play Again",e);s.appendChild(i),s.appendChild(r),S(s)}function ft(){let e,t=0,i=!0;const{canvas:n,context:s}=K();function r(h){e==null||e.updateAll(h,a)}function c(){e==null||e.drawAll()}function l(h){if(!e)return;const _=i?0:h-t;i=!1,t=h,r(_),c(),requestAnimationFrame(l)}function a(h){t=0,e=void 0,ht(h,()=>v(m))}function m(){V(n,A),i=!0,e=new at(s),requestAnimationFrame(l)}function A(){t=0,e=void 0,v(m)}function P(){t=0,e=void 0,dt(()=>v(m))}v(m,P)}onload=()=>ft();
