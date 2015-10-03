precision mediump float;

uniform sampler2D vTex;
varying vec2 vCoord;

void main(void)
{
    vec2 off = vec2(0.0, 0.0);
    if (vCoord.s > 0.5)
        {
        off.s = 1.0 - vCoord.s;
        off.t = vCoord.t;
        }
    else
         off = vCoord;
    vec3 color = texture2D(vTex, vec2(off)).bgr;
    gl_FragColor.a = 1.0;
    gl_FragColor.rgb = color;
}
