//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PSMoveService {

public class PSMTrackingProjection_shape : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PSMTrackingProjection_shape(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PSMTrackingProjection_shape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PSMTrackingProjection_shape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PSMoveClientPINVOKE.delete_PSMTrackingProjection_shape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PSMTrackingProjection_shape_ellipse ellipse {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMTrackingProjection_shape_ellipse_get(swigCPtr);
      PSMTrackingProjection_shape_ellipse ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMTrackingProjection_shape_ellipse(cPtr, false);
      return ret;
    } 
  }

  public PSMTrackingProjection_shape_lightbar lightbar {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMTrackingProjection_shape_lightbar_get(swigCPtr);
      PSMTrackingProjection_shape_lightbar ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMTrackingProjection_shape_lightbar(cPtr, false);
      return ret;
    } 
  }

  public PSMTrackingProjection_shape_pointcloud pointcloud {
    get {
      global::System.IntPtr cPtr = PSMoveClientPINVOKE.PSMTrackingProjection_shape_pointcloud_get(swigCPtr);
      PSMTrackingProjection_shape_pointcloud ret = (cPtr == global::System.IntPtr.Zero) ? null : new PSMTrackingProjection_shape_pointcloud(cPtr, false);
      return ret;
    } 
  }

  public PSMTrackingProjection_shape() : this(PSMoveClientPINVOKE.new_PSMTrackingProjection_shape(), true) {
  }

}

}