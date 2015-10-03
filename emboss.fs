precision mediump float;

uniform sampler2D vTex;
varying vec2 vCoord;

const float step_w = 0.0015625;
const float step_h = 0.0027778;

void main(void)
{
    vec3 t1 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y - step_h)).bgr;
    vec3 t2 = texture2D(vTex, vec2(vCoord.x, vCoord.y - step_h)).bgr;
    vec3 t3 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y - step_h)).bgr;
    vec3 t4 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y)).bgr;
    vec3 t5 = texture2D(vTex, vCoord).bgr;
    vec3 t6 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y)).bgr;
    vec3 t7 = texture2D(vTex, vec2(vCoord.x - step_w, vCoord.y + step_h)).bgr;
    vec3 t8 = texture2D(vTex, vec2(vCoord.x, vCoord.y + step_h)).bgr;
    vec3 t9 = texture2D(vTex, vec2(vCoord.x + step_w, vCoord.y + step_h)).bgr;
   
    vec3 rr = -4.0 * t1 - 4.0 * t2 - 4.0 * t4 + 12.0 * t5;
    float y = (rr.r + rr.g + rr.b) / 3.0;
 
    gl_FragColor.a = 1.0;
    gl_FragColor.rgb = vec3(y, y, y) + 0.3;
}
