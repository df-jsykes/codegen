package com.dreamfactory.model;

import com.fasterxml.jackson.annotation.JsonProperty;

import com.dreamfactory.model.Role;
import com.dreamfactory.model.App;
public class UserRequest {
  /* Identifier of this user. */
  @JsonProperty("id")
  private Integer id = null;
  /* The email address required for this user. */
  @JsonProperty("email")
  private String email = null;
  /* The set-able, but never readable, password. */
  @JsonProperty("password")
  private String password = null;
  /* The first name for this user. */
  @JsonProperty("first_name")
  private String first_name = null;
  /* The last name for this user. */
  @JsonProperty("last_name")
  private String last_name = null;
  /* Displayable name of this user. */
  @JsonProperty("display_name")
  private String display_name = null;
  /* Phone number for this user. */
  @JsonProperty("phone")
  private String phone = null;
  /* True if this user is active for use. */
  @JsonProperty("is_active")
  private Boolean is_active = null;
  /* True if this user is a system admin. */
  @JsonProperty("is_sys_admin")
  private Boolean is_sys_admin = null;
  /* The default launched app for this user. */
  @JsonProperty("default_app_id")
  private String default_app_id = null;
  /* The role to which this user is assigned. */
  @JsonProperty("role_id")
  private String role_id = null;
  /* Related app by default_app_id. */
  @JsonProperty("default_app")
  private App default_app = null;
  /* Related role by role_id. */
  @JsonProperty("role")
  private Role role = null;
  public Integer getId() {
    return id;
  }
  public void setId(Integer id) {
    this.id = id;
  }

  public String getEmail() {
    return email;
  }
  public void setEmail(String email) {
    this.email = email;
  }

  public String getPassword() {
    return password;
  }
  public void setPassword(String password) {
    this.password = password;
  }

  public String getFirst_name() {
    return first_name;
  }
  public void setFirst_name(String first_name) {
    this.first_name = first_name;
  }

  public String getLast_name() {
    return last_name;
  }
  public void setLast_name(String last_name) {
    this.last_name = last_name;
  }

  public String getDisplay_name() {
    return display_name;
  }
  public void setDisplay_name(String display_name) {
    this.display_name = display_name;
  }

  public String getPhone() {
    return phone;
  }
  public void setPhone(String phone) {
    this.phone = phone;
  }

  public Boolean getIs_active() {
    return is_active;
  }
  public void setIs_active(Boolean is_active) {
    this.is_active = is_active;
  }

  public Boolean getIs_sys_admin() {
    return is_sys_admin;
  }
  public void setIs_sys_admin(Boolean is_sys_admin) {
    this.is_sys_admin = is_sys_admin;
  }

  public String getDefault_app_id() {
    return default_app_id;
  }
  public void setDefault_app_id(String default_app_id) {
    this.default_app_id = default_app_id;
  }

  public String getRole_id() {
    return role_id;
  }
  public void setRole_id(String role_id) {
    this.role_id = role_id;
  }

  public App getDefault_app() {
    return default_app;
  }
  public void setDefault_app(App default_app) {
    this.default_app = default_app;
  }

  public Role getRole() {
    return role;
  }
  public void setRole(Role role) {
    this.role = role;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserRequest {\n");
    sb.append("  id: ").append(id).append("\n");
    sb.append("  email: ").append(email).append("\n");
    sb.append("  password: ").append(password).append("\n");
    sb.append("  first_name: ").append(first_name).append("\n");
    sb.append("  last_name: ").append(last_name).append("\n");
    sb.append("  display_name: ").append(display_name).append("\n");
    sb.append("  phone: ").append(phone).append("\n");
    sb.append("  is_active: ").append(is_active).append("\n");
    sb.append("  is_sys_admin: ").append(is_sys_admin).append("\n");
    sb.append("  default_app_id: ").append(default_app_id).append("\n");
    sb.append("  role_id: ").append(role_id).append("\n");
    sb.append("  default_app: ").append(default_app).append("\n");
    sb.append("  role: ").append(role).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

