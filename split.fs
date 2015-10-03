precision mediump float;

uniform sampler2D vTex;
varying vec2 vCoord;

void main(void)
{
    vec2 off = vCoord;
    if (off.s > 0.5)
        {
        off.s = off.s - 0.5;
        if (off.t > 0.5)
            off.t = off.t - 0.5;
        }
    else
        {
        if (off.t > 0.5)
             off.t = off.t - 0.5;
        }
    vec3 color = texture2D(vTex, vec2(off)).bgr;
    gl_FragColor.a = 1.0;
    gl_FragColor.rgb = color;
}
